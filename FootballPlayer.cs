namespace My_First_App
{
    public class FootballPlayer
    {
        string _team;
        string _position;
        string _age;
        string _height;
        string _weight;

        public string Team {get; set;}
        public string Position {
            get{
                return _position;
            }
            set{
                this._position = value;
            }
        }
        public string Height {
            get{
                return _height;
            }
            set{
                this._height = value;
            }
        }
        public string Age {
            get{
                return _age;
            }
            set{
                this._age = value;
            }
        }
        public string Weight {
            get{
                return _weight;
            }
            set{
                this._weight = value;
            }
        }
 
        
        public void Team() {

        }
    }
}