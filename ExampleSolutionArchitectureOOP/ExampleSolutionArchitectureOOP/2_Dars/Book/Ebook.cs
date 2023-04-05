namespace Payshanba
{
    public class Ebook : Book
    {
        //   EBook fieldlari — yuklab olinadigan sayt va hajmi(MB)
        //  EBook methodlari —sarlovhani chop etish

        private string _saytname;
        private int _hajm;

        public string Saytname
        {
            get { return _saytname; }
            set { _saytname = value; }
        }
        public int Hajm
        {
            get { return _hajm; }
            set { _hajm = value; }
        }

        public static void Chop(string Title)
        {
            Book book = new Book();
            book.Title = "Yulduzlar mangu yonadi!";
            Console.WriteLine(book.Title);
        }
    }
}
