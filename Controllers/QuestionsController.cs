using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AfricasTalkingCS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.EntityModels;

namespace CRM.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly CrmContext _context;

        public QuestionsController(CrmContext context)
        {
            _context = context;
        }

        // GET: Questions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Questions.FromSql("select * from Questions order by Code").ToListAsync());
        }
        public async Task<IActionResult> Responses(string Id)
        {
            return View(await _context.Responses.Where(i => i.QuestionId == Id).ToListAsync());
        }
        public async Task<IActionResult> AddResponseAsync(string Id)
        {
            ViewData["Id"] = Id;
            ViewData["Questions"] = await _context.Questions.FromSql("select * from Questions order by Code").ToListAsync();
            return View();
        }
        public async Task<IActionResult>AddCustomerExperience(string customerId,string responseId,string isFirst)
        {
            ViewData["CustomerId"] = customerId;
            if (isFirst.Equals("True",StringComparison.InvariantCultureIgnoreCase))
            {
                var m= await _context.Questions.OrderBy(i => i.Code).FirstOrDefaultAsync();
                ViewData["Question"] = m;
                ViewData["Responses"] = await _context.Responses.Where(i => i.QuestionId == m.Id).ToListAsync();
                return View();
                   
            }
            var response = await _context.Responses.FirstOrDefaultAsync(i => i.Id == responseId);
            if(string.IsNullOrEmpty(response.NextQuestion))
            {
                string id = customerId;
                string username = "sandbox"; // substitute with your username if mot using sandbox
                string apikey = "5e515cfb45d3056ee46fa24c73414b61c2cb0a43424e0e835100e2ce075bffbc"; // substitute with your production API key if not using sandbox
                var customer = await _context.Customers.FindAsync(customerId);
                var gateway = new AfricasTalkingGateway(username, apikey);
                var sms = gateway.SendMessage(customer.Phone, $"Dear {customer.FullName} Thank you for contactinG ABC ");
                return RedirectToAction("GetCustomerResponse","Customers",new{id });
            }
            var q = await _context.Questions.Where(i=>i.Id==response.NextQuestion).FirstOrDefaultAsync();
            ViewData["Question"] = q;
            ViewData["Responses"] = await _context.Responses.Where(i => i.QuestionId == q.Id).ToListAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomerResponses(string customerId,string responseId)
        {
            var response = await _context.Responses.FindAsync(responseId);
            await _context.CustomerResponses.AddAsync(new CustomerResponse
            {
               CustomerId=customerId,
               QuestionId=response.QuestionId,
               ResponseId=responseId,
            });
            await _context.SaveChangesAsync();
            string isFirst = "false";
            return RedirectToAction(nameof(AddCustomerExperience), new { customerId,responseId, isFirst });

        }
        [HttpPost]

        public async Task<IActionResult> AddResponsePost(Response response)
        {
            if (response.IsEnd == true)
            {
                response.NextQuestion = null;
                await _context.Responses.AddAsync(response);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            var resp1 = await _context.Questions.FindAsync(response.QuestionId);
            var resp2 = await _context.Questions.FindAsync(response.NextQuestion);
            
            if (resp2.Code < resp1.Code)
            {
                return BadRequest();
            }

          await  _context.Responses.AddAsync(response);
            await _context.SaveChangesAsync();
         return   RedirectToAction(nameof(Index));
        }
        
        // GET: Questions/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        // GET: Questions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,IsBinary,Id,DateCreated,CreatedBy")] Question question)
        {
            if (ModelState.IsValid)
            {
                _context.Add(question);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(question);
        }

        // GET: Questions/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }
            return View(question);
        }

        // POST: Questions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(Question question)
        {
            if (question.Id==null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var t = await _context.Questions.FindAsync(question.Id);
                    if (t == null)
                        return NotFound();
                    t.Description = question.Description;
                    t.IsBinary = question.IsBinary;
                  await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionExists(question.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(question);
        }

        // GET: Questions/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        // POST: Questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var question = await _context.Questions.FindAsync(id);
            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionExists(string id)
        {
            return _context.Questions.Any(e => e.Id == id);
        }
    }
}
