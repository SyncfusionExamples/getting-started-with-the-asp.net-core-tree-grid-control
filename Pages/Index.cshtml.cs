using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mycoreproject.Pages
{
    public class TreeGridData
    {
        public int TaskId { get; set; }
        public string? TaskName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Duration { get; set; }

        public int Progress { get; set; }
        public string? Priority { get; set; }
        public bool Approved { get; set; }

        public List<TreeGridData>? Children { get; set; }

        public static List<TreeGridData> GetDefaultData()
        {
            List<TreeGridData> HeirarchicalData = new List<TreeGridData>();

            TreeGridData? Parent1 = null;

            Parent1 = new TreeGridData()
            {
                TaskId = 1,
                TaskName = "Planning",
                StartDate = new DateTime(2017, 03, 02),
                EndDate = new DateTime(2017, 07, 02),
                Progress = 100,
                Duration = 5,
                Priority = "Normal",
                Approved = false,
                Children = new List<TreeGridData>(),
            };

            TreeGridData Child1 = new TreeGridData()
            {
                TaskId = 2,
                TaskName = "Plan timeline",
                StartDate = new DateTime(2017, 03, 02),
                EndDate = new DateTime(2017, 07, 02),
                Progress = 100,
                Duration = 5,
                Priority = "Normal",
                Approved = false,
            };

            TreeGridData Child2 = new TreeGridData()
            {
                TaskId = 3,
                TaskName = "Plan budget",
                StartDate = new DateTime(2017, 03, 02),
                EndDate = new DateTime(2017, 07, 02),
                Duration = 5,
                Progress = 100,
                Approved = true,
                Priority = "Low",
            };

            TreeGridData Child3 = new TreeGridData()
            {
                TaskId = 4,
                TaskName = "Allocate resources",
                StartDate = new DateTime(2017, 03, 02),
                EndDate = new DateTime(2017, 07, 02),
                Duration = 5,
                Progress = 100,
                Priority = "Critical",
                Approved = false
            };

            TreeGridData Child4 = new TreeGridData()
            {
                TaskId = 5,
                TaskName = "Planning complete",
                StartDate = new DateTime(2017, 07, 02),
                EndDate = new DateTime(2017, 07, 02),
                Duration = 1,
                Progress = 1,
                Priority = "Low",
                Approved = true
            };

            Parent1.Children.Add(Child1);
            Parent1.Children.Add(Child2);
            Parent1.Children.Add(Child3);
            Parent1.Children.Add(Child4);

            TreeGridData Record2 = new TreeGridData()
            {
                TaskId = 6,
                TaskName = "Design",
                StartDate = new DateTime(2017, 10, 02),
                EndDate = new DateTime(2017, 02, 14),
                Progress = 86,
                Duration = 3,
                Priority = "High",
                Approved = false,
                Children = new List<TreeGridData>(),
            };

            TreeGridData Child5 = new TreeGridData()
            {
                TaskId = 7,
                TaskName = "Software Specification",
                StartDate = new DateTime(2017, 10, 02),
                EndDate = new DateTime(2017, 02, 12),
                Duration = 3,
                Progress = 60,
                Priority = "Normal",
                Approved = false
            };

            TreeGridData Child6 = new TreeGridData()
            {
                TaskId = 8,
                TaskName = "Develop prototype",
                StartDate = new DateTime(2017, 10, 02),
                EndDate = new DateTime(2017, 02, 12),
                Duration = 3,
                Progress = 100,
                Priority = "Critical",
                Approved = false
            };

            TreeGridData Child7 = new TreeGridData()
            {
                TaskId = 9,
                TaskName = "Get approval from customer",
                StartDate = new DateTime(2017, 02, 13),
                EndDate = new DateTime(2017, 02, 14),
                Duration = 2,
                Progress = 100,
                Priority = "Low",
                Approved = true
            };

            TreeGridData Child8 = new TreeGridData()
            {
                TaskId = 10,
                TaskName = "Design complete",
                StartDate = new DateTime(2017, 02, 14),
                EndDate = new DateTime(2017, 02, 14),
                Duration = 1,
                Progress = 1,
                Priority = "Normal",
                Approved = true
            };

            Record2.Children.Add(Child5);
            Record2.Children.Add(Child6);
            Record2.Children.Add(Child7);
            Record2.Children.Add(Child8);
            TreeGridData Record3 = new TreeGridData()
            {
                TaskId = 11,
                TaskName = "Implementation Phase",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 17),
                Priority = "Normal",
                Approved = false,
                Duration = 11,
                Progress = 66,
                Children = new List<TreeGridData>(),
            };

            TreeGridData Record4 = new TreeGridData()
            {
                TaskId = 12,
                TaskName = "Phase 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 27),
                Priority = "High",
                Approved = false,
                Duration = 11,
                Progress = 50,
                Children = new List<TreeGridData>(),
            };
            TreeGridData Record7 = new TreeGridData()
            {
                TaskId = 13,
                TaskName = "Implementation Module 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 27),
                Priority = "Normal",
                Duration = 11,
                Progress = 10,
                Approved = false,
                Children = new List<TreeGridData>(),
            };
            TreeGridData Child9 = new TreeGridData()
            {
                TaskId = 14,
                TaskName = "Development Task 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 19),
                Duration = 3,
                Progress = 50,
                Priority = "High",
                Approved = false
            };
            TreeGridData Child10 = new TreeGridData()
            {
                TaskId = 15,
                TaskName = "Development Task 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 19),
                Duration = 3,
                Progress = 50,
                Priority = "Low",
                Approved = true
            };
            TreeGridData Child11 = new TreeGridData()
            {
                TaskId = 16,
                TaskName = "Testing",
                StartDate = new DateTime(2017, 02, 20),
                EndDate = new DateTime(2017, 02, 21),
                Duration = 2,
                Progress = 1,
                Priority = "Normal",
                Approved = true
            };
            TreeGridData Child12 = new TreeGridData()
            {
                TaskId = 17,
                TaskName = "Bug fix",
                StartDate = new DateTime(2017, 02, 24),
                EndDate = new DateTime(2017, 02, 25),
                Duration = 2,
                Progress = 1,
                Priority = "Critical",
                Approved = false
            };
            TreeGridData Child13 = new TreeGridData()
            {
                TaskId = 18,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2017, 02, 26),
                EndDate = new DateTime(2017, 02, 27),
                Duration = 2,
                Progress = 1,
                Priority = "High",
                Approved = false
            };
            TreeGridData Child14 = new TreeGridData()
            {
                TaskId = 19,
                TaskName = "Phase 1 complete",
                StartDate = new DateTime(2017, 02, 27),
                EndDate = new DateTime(2017, 02, 27),
                Duration = 2,
                Progress = 50,
                Priority = "Low",
                Approved = true
            };
            Record7.Children.Add(Child9);
            Record7.Children.Add(Child10);
            Record7.Children.Add(Child11);
            Record7.Children.Add(Child12);
            Record7.Children.Add(Child13);
            Record7.Children.Add(Child14);
            Record4.Children.Add(Record7);
            Record3.Children.Add(Record4);
            TreeGridData Record5 = new TreeGridData()
            {
                TaskId = 20,
                TaskName = "Phase 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 28),
                Children = new List<TreeGridData>(),
                Priority = "High",
                Approved = false,
                Progress = 60,
                Duration = 12,
            };
            TreeGridData Record8 = new TreeGridData()
            {
                TaskId = 21,
                TaskName = "Implementation Module 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 28),
                Priority = "Critical",
                Approved = false,
                Progress = 90,
                Duration = 12,
                Children = new List<TreeGridData>(),
            };
            TreeGridData Child15 = new TreeGridData()
            {
                TaskId = 22,
                TaskName = "Development Task 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 20),
                Duration = 4,
                Progress = 50,
                Priority = "Normal",
                Approved = true,
            };
            TreeGridData Child16 = new TreeGridData()
            {
                TaskId = 23,
                TaskName = "Development Task 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 20),
                Duration = 4,
                Progress = 50,
                Priority = "Critical",
                Approved = true,
            };
            TreeGridData Child17 = new TreeGridData()
            {
                TaskId = 24,
                TaskName = "Testing",
                StartDate = new DateTime(2017, 02, 21),
                EndDate = new DateTime(2017, 02, 24),
                Duration = 2,
                Progress = 1,
                Priority = "High",
                Approved = false,
            };
            TreeGridData Child18 = new TreeGridData()
            {
                TaskId = 25,
                TaskName = "Bug fix",
                StartDate = new DateTime(2017, 02, 25),
                EndDate = new DateTime(2017, 02, 26),
                Duration = 2,
                Progress = 1,
                Priority = "Low",
                Approved = false,
            };
            TreeGridData Child19 = new TreeGridData()
            {
                TaskId = 26,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2017, 02, 27),
                EndDate = new DateTime(2017, 02, 28),
                Duration = 2,
                Progress = 1,
                Priority = "Critical",
                Approved = true,
            };
            TreeGridData Child20 = new TreeGridData()
            {
                TaskId = 27,
                TaskName = "Phase 2 complete",
                StartDate = new DateTime(2017, 02, 28),
                EndDate = new DateTime(2017, 02, 28),
                Duration = 2,
                Priority = "Normal",
                Progress = 50,
                Approved = false,
            };
            Record8.Children.Add(Child15);
            Record8.Children.Add(Child16);
            Record8.Children.Add(Child17);
            Record8.Children.Add(Child18);
            Record8.Children.Add(Child19);
            Record8.Children.Add(Child20);
            Record5.Children.Add(Record8);
            Record3.Children.Add(Record5);
            TreeGridData Record6 = new TreeGridData()
            {
                TaskId = 28,
                TaskName = "Phase 3",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 27),
                Priority = "Normal",
                Approved = false,
                Duration = 11,
                Progress = 30,
                Children = new List<TreeGridData>(),
            };
            TreeGridData Record9 = new TreeGridData()
            {
                TaskId = 29,
                TaskName = "Implementation Module 3",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 27),
                Priority = "High",
                Approved = false,
                Duration = 11,
                Progress = 60,
                Children = new List<TreeGridData>(),
            };
            TreeGridData Child21 = new TreeGridData()
            {
                TaskId = 30,
                TaskName = "Development Task 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 19),
                Duration = 3,
                Progress = 50,
                Priority = "Low",
                Approved = true,
            };
            TreeGridData Child22 = new TreeGridData()
            {
                TaskId = 31,
                TaskName = "Development Task 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 19),
                Duration = 3,
                Progress = 50,
                Priority = "Normal",
                Approved = false,
            };
            TreeGridData Child23 = new TreeGridData()
            {
                TaskId = 32,
                TaskName = "Testing",
                StartDate = new DateTime(2017, 02, 20),
                EndDate = new DateTime(2017, 02, 21),
                Duration = 2,
                Progress = 1,
                Priority = "Critical",
                Approved = true,

            };
            TreeGridData Child24 = new TreeGridData()
            {
                TaskId = 33,
                TaskName = "Bug fix",
                StartDate = new DateTime(2017, 02, 24),
                EndDate = new DateTime(2017, 02, 25),
                Duration = 2,
                Progress = 1,
                Priority = "High",
                Approved = false,
            };
            TreeGridData Child25 = new TreeGridData()
            {
                TaskId = 34,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2017, 02, 26),
                EndDate = new DateTime(2017, 02, 27),
                Duration = 2,
                Progress = 1,
                Priority = "Normal",
                Approved = true,
            };
            TreeGridData Child26 = new TreeGridData()
            {
                TaskId = 35,
                TaskName = "Phase 3 complete",
                StartDate = new DateTime(2017, 02, 27),
                EndDate = new DateTime(2017, 02, 27),
                Duration = 2,
                Priority = "Critical",
                Progress = 50,
                Approved = false,
            };
            Record9.Children.Add(Child21);
            Record9.Children.Add(Child22);
            Record9.Children.Add(Child23);
            Record9.Children.Add(Child24);
            Record9.Children.Add(Child25);
            Record9.Children.Add(Child26);
            Record6.Children.Add(Record9);
            Record3.Children.Add(Record6);
            HeirarchicalData.Add(Parent1);
            HeirarchicalData.Add(Record2);
            HeirarchicalData.Add(Record3);

            return HeirarchicalData;
        }
   
    }
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
