using System.Linq;
using SQLite.Net.Attributes;

namespace CrazyQuiz
{
    [Table("scores")]
    public class ScoreUser
    {
        private string _name;

        [PrimaryKey]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value.ToUpper().Split(' ').First();
            }
        }

        public ScoreUser() { }
        public ScoreUser(string name)
        {
            Name = name;
        }
    }
}