namespace Calencadabra.Models
{
    public class Note
    {
        private string _text = string.Empty;

        public DateTime DateCreated { get; } = DateTime.Now;
        public DateTime DateLastModified { get; set; } = DateTime.Now;
        public string Text{ get { return _text; } }

        public bool Set(string text_in)
        {
            try
            {
                _text = text_in;
                DateLastModified = DateTime.Now;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }   
            return true;
        }
    }
}
