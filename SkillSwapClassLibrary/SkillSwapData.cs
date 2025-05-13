using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSwapClassLibrary
{
    public class SkillSwapData
    {
        private static DataSet _festivalDataset;
        private static DataTable _dtCategories;
        private static DataTable _dtWorkshops;

        public static DataSet SkillSwapDataSet { get { return _festivalDataset; } }
        public static DataTable CategoriesDataTable { get { return _dtCategories; } }
        public static DataTable WorkshopsDataTable { get { return _dtWorkshops; } }


        public static void GetSkillSwapDataSet()
        {
            // Create a new dataset
            _festivalDataset = new DataSet("PXLSkillSwap");

            // Create a DataTable for Category
            _dtCategories = new DataTable("Categories");
            _dtCategories.Columns.Add("CategoryId", typeof(int));
            _dtCategories.Columns.Add("CategoryName", typeof(string));
            _dtCategories.PrimaryKey = new DataColumn[] { _dtCategories.Columns[0] };

            _dtCategories.Rows.Add(1, "Sports");
            _dtCategories.Rows.Add(2, "Music");
            _dtCategories.Rows.Add(3, "Technology");

            // Create a DataTable for workshops
            _dtWorkshops = new DataTable("Workshops");
            _dtWorkshops.Columns.Add("WorkshopId", typeof(int));
            _dtWorkshops.Columns.Add("WorkshopName", typeof(string));
            _dtWorkshops.Columns.Add("CategoryId", typeof(int));
            _dtWorkshops.Columns.Add("Description", typeof(string));
            _dtWorkshops.Columns.Add("Time", typeof(DateTime));
            _dtWorkshops.Columns.Add("Location", typeof(string));
            _dtWorkshops.PrimaryKey = new DataColumn[] { _dtWorkshops.Columns[0] };
            _dtWorkshops.Constraints.Add(
                new ForeignKeyConstraint(
                    _dtCategories.Columns[0],
                    _dtWorkshops.Columns[2]));

            // Add records to sports
            _dtWorkshops.Rows.Add(1, "Running for beginners", 1, "Learn the basics of running and how to improve your technique", new DateTime(2023, 6, 15, 9, 0, 0), "Building A");
            _dtWorkshops.Rows.Add(2, "E-sports tournament", 1, "Compete against others in a tournament of popular video games", new DateTime(2023, 6, 16, 13, 0, 0), "Building G");
            _dtWorkshops.Rows.Add(3, "Indoor rowing", 1, "Try out indoor rowing machines and learn about proper form and technique", new DateTime(2023, 6, 17, 11, 0, 0), "Buildings B");

            // Add records to music
            _dtWorkshops.Rows.Add(4, "DJ workshop", 2, "Learn how to mix tracks and use DJ equipment like a pro", new DateTime(2023, 6, 15, 14, 0, 0), "Building D");
            _dtWorkshops.Rows.Add(5, "Live music showcase", 2, "Listen to up-and-coming artists perform live on stage", new DateTime(2023, 6, 16, 18, 0, 0), "Buildings B");
            _dtWorkshops.Rows.Add(6, "Music production masterclass", 2, "Learn how to create your own music using software like Ableton Live", new DateTime(2023, 6, 17, 15, 0, 0), "Building G");

            // Add records to technologyTable
            _dtWorkshops.Rows.Add(7, "C# programming basics", 3, "Learn the fundamentals of C# programming language", new DateTime(2023, 6, 15, 10, 0, 0), "Building G");
            _dtWorkshops.Rows.Add(8, "Software development in the real world", 3, "Hear from professionals about their experiences developing software for various industries", new DateTime(2023, 6, 16, 16, 0, 0), "Building D");
            _dtWorkshops.Rows.Add(9, "Robotics showcase", 3, "See the latest advancements in robotics technology and meet the creators", new DateTime(2023, 6, 17, 12, 0, 0), "Building B");
            _dtWorkshops.Rows.Add(10, "Novel drone applications", 3, "Discover new and innovative uses for drones in various industries", new DateTime(2023, 6, 18, 14, 0, 0), "Building A");
            _dtWorkshops.Rows.Add(11, "Learn to fly a drone", 3, "Get hands-on experience flying a drone and learn about safety regulations", new DateTime(2023, 6, 19, 10, 0, 0), "Building G");

            _festivalDataset.Tables.Add(_dtWorkshops);
            _festivalDataset.Tables.Add(_dtCategories);
        }
    }
}
