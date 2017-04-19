using System;

namespace RepeatableQuotes
{
    public class QuoteViewer
    {
        // Fields
        private int _count;

        // Constructors
        public QuoteViewer()
        {
            // Empty!
        }

        public QuoteViewer(string quote, int count)
        {
            Quote = quote;
            Count = count;
        }

        // Properties
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public string Quote { get; set; }

        // Methods
        public void View()
        {
            Console.WriteLine("-----");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(Quote);
            }
            Console.WriteLine("-----");
        }
    }
}