using VivesActivities.Ui.Mvc.Models;

namespace VivesActivities.Ui.Mvc.Core
{
    public class Database
    {
        public IList<VivesActivity> Activities { get; set; } = new List<VivesActivity>();

        public void Seed()
        {
            Activities = new List<VivesActivity>
            {
                new VivesActivity
                {
                    Id = 1,
                    Name = "Soccer",
                    Type = "Team Sport",
                    Location = "Stadium 1",
                    Description = "Description of Soccer"
                },
                new VivesActivity
                {
                    Id = 2,
                    Name = "Tennis",
                    Type = "Individual Sport",
                    Location = "Court 1",
                    Description = "Description of Tennis"
                },
                new VivesActivity
                {
                    Id = 3,
                    Name = "Basketball",
                    Type = "Team Sport",
                    Location = "Arena 1",
                    Description = "Description of Basketball"
                },
                new VivesActivity
                {
                    Id = 4,
                    Name = "Swimming",
                    Type = "Individual Sport",
                    Location = "Pool 1",
                    Description = "Description of Swimming"
                },
                new VivesActivity
                {
                    Id = 5,
                    Name = "Volleyball",
                    Type = "Team Sport",
                    Location = "Beach 1",
                    Description = "Description of Volleyball"
                },
                new VivesActivity
                {
                    Id = 6,
                    Name = "Golf",
                    Type = "Individual Sport",
                    Location = "Course 1",
                    Description = "Description of Golf"
                },
                new VivesActivity
                {
                    Id = 7,
                    Name = "Badminton",
                    Type = "Individual Sport",
                    Location = "Court 2",
                    Description = "Description of Badminton"
                },
                new VivesActivity
                {
                    Id = 8,
                    Name = "Hockey",
                    Type = "Team Sport",
                    Location = "Field 1",
                    Description = "Description of Hockey"
                },
                new VivesActivity
                {
                    Id = 9,
                    Name = "Table Tennis",
                    Type = "Individual Sport",
                    Location = "Recreation Center 1",
                    Description = "Description of Table Tennis"
                },
                new VivesActivity
                {
                    Id = 10,
                    Name = "Rugby",
                    Type = "Team Sport",
                    Location = "Field 2",
                    Description = "Description of Rugby"
                }
            };
        }
    }
}
