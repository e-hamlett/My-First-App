namespace My_First_App
{
    public class VideoGame
    {
        //string _case;
        string _disc;
        string _coverart;

        public string Case {get; set;}
        
        public string Disc {
            get {
                return _disc;
            }
            set {
                this._disc = value;
            }
        }

        public string Coverart {
            get {
                return _coverart;
            }
            set{
                this._coverart = value;
            }
        }

        public void OpenCase() 
        {

        }
        public void CloseCase() 
        {

        }
        public void InsertDisc() 
        {

        }
        public void RemoveDisc() 
        {

        }
        public void ApplyCoverart() 
        {

        }
        public void RemoveCoverart() 
        {

        }
    }
}