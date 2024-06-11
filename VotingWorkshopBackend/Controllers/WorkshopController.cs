using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VotingWorkshopBackend.Model;

namespace VotingWorkshopBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkshopController : Controller
    {
        public WssVotingWorkshopSystemContext dbContxext = new();

        [HttpGet]
        public IActionResult Index()
        {
            WorkshopRequest[] workshops = dbContxext.WorkshopRequests
                .Include(w => w.User)
                .Include(w => w.Saloon)
                .Include(w => w.Category)
                .Include(w => w.WorkshopTimeslot)
                .Include(w => w.Status)
                .ToArray();
            WorkshopView[] workshopsView = new WorkshopView[workshops.Length];
            int i = 0;
            foreach (WorkshopRequest w in workshops)
            {
                WorkshopView wv = new WorkshopView()
                {
                    WorkshopRequestId = w.WorkshopRequestId,
                    User = w.User.Username,
                    Saloon = w.Saloon.SaloonName,
                    Category = w.Category.CategoryName,
                    TimeslotStart = w.WorkshopTimeslot.StartTime.ToString(),
                    TimeslotEnd = w.WorkshopTimeslot.EndTime.ToString(),
                    Status = w.Status.StatusName,
                    Date = w.Date
                };
                workshopsView[i] = wv;
                i++;
            }

            return Ok(workshopsView);
        }

        [HttpGet("options")]
        public IActionResult GetWorkshopOptions()
        {
            WorkshopOptions workshopOptions = new WorkshopOptions()
            {
                Saloons = dbContxext.Saloons.ToArray(),
                Categories = dbContxext.Categories.ToArray(),
                WorkshopTimeslots = dbContxext.WorkshopTimeslots.ToArray(),
                Statuses = dbContxext.Statuses.ToArray()
            };
            return Ok(workshopOptions);
        }

        [HttpPost("new")]
        public IActionResult NewWorkshopRequest([FromBody] NewWorkshopRequestFormat workshopRequestFormat)
        {
            WorkshopRequest workshopRequest = new WorkshopRequest()
            {
                UserId = workshopRequestFormat.UserId,
                SaloonId = workshopRequestFormat.SaloonId,
                CategoryId = workshopRequestFormat.CategoryId,
                WorkshopTimeslotId = workshopRequestFormat.WorkshopTimeslotId,
                StatusId = workshopRequestFormat.StatusId,
                Date = workshopRequestFormat.Date
            };
            dbContxext.WorkshopRequests.Add(workshopRequest);
            dbContxext.SaveChanges();

            return Ok();
        }

        public class WorkshopOptions
        {
            public required Saloon[] Saloons { get; set; }
            public required Category[] Categories { get; set; }
            public required WorkshopTimeslot[] WorkshopTimeslots { get; set; }
            public required Status[] Statuses { get; set; }
        }

        public class NewWorkshopRequestFormat
        {
            public required int UserId { get; set; }
            public required int SaloonId { get; set; }
            public required int CategoryId { get; set; }
            public required int WorkshopTimeslotId { get; set; }
            public required int StatusId { get; set; }
            public required DateTime Date { get; set; }
        }
    }
}
