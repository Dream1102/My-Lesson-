namespace Payshanba
{
    public class Book
    {
        // . Rasmdagi struktura bo’yicha klasslarni yarating.Bunda: 
        //Book fieldlari:  — Avtori, narxi, chegirmasi, sarlovhasi va sahifalar soni
        //Book methodlari — sotuv narxini hisoblash, bojxona to’lovini hisoblash(sotuv narxini 30 %)
        //   EBook fieldlari — yuklab olinadigan sayt va hajmi(MB)
        //  EBook methodlari —sarlovhani chop etish
        //  PayperBook fieldlari – vazni, yetkazib berish vaqti(kun) (oson)

        private string _author;
        private int _price;
        private string _title;
        private int _discount;
        private int _titlenumber;

        public static void Sotuv(int _price, int _discount)
        {
            Console.WriteLine( $"{_price - _discount}");
        }

        public static void Bojhona( int Sotuv )
        {
            Console.WriteLine($" Bu Bojhona to'lovi narxi :{Sotuv/0.3}");
        }
        public string Author
        {
            get { return _author; }
            set
            {
                if (value.All(char.IsLetter))
                    _author = value;
            }
        }
        public int Price
        {
            
         get { return _price; }
            set
            {
                if (value > 0 || value != null) _author = value.ToString();
                else Console.WriteLine("Error");
            }
        }

        public int Discount
        {
            get { return _discount; }
            set
            {
                if (value > 0 || value != null) _author = _discount.ToString();
                Console.WriteLine("Error");
            }
        }
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
            }
        }
        public int Titlenumber
        {
            get { return _titlenumber; }
            set { _titlenumber = value; }
        }

        public override bool Equals(object? obj)
        {
            return obj is Book book &&
                   _author == book._author &&
                   _price == book._price &&
                   _title == book._title &&
                   _discount == book._discount &&
                   _titlenumber == book._titlenumber &&
                   Author == book.Author &&
                   Price == book.Price &&
                   Discount == book.Discount &&
                   Title == book.Title &&
                   Titlenumber == book.Titlenumber;
        }
    }
}
