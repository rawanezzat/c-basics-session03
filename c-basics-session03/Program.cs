using System.Collections;
using System.Diagnostics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_basics_session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region session 2

            Console.WriteLine("assignment 2");

            #region Q5
            Console.WriteLine("-------Q5------ ");

            int pages = 300;
            double pages_num = pages;
            Console.WriteLine("convert int to double without casting");
            Console.WriteLine(pages_num);

            #endregion

            #region Q6
            Console.WriteLine("-------Q6------ ");

            double price = 49.99;
            int price_num = (int)price;
            Console.WriteLine("convert double to int with casting");
            Console.WriteLine(price_num);
            #endregion


            #region Q7
            Console.WriteLine("-------Q7------ ");

            string pagesText = "464";
            int pages_converted = Convert.ToInt32(pagesText);
            Console.WriteLine("convert string to int using Convert.ToInt32 (convert class)");
            Console.WriteLine(pages_converted);
            #endregion


            #region Q8
            Console.WriteLine("-------Q8------ ");

            string yearText = "2023";
            int year_converted = int.Parse(yearText);
            Console.WriteLine("convert string to int using int.Parse");
            Console.WriteLine(year_converted);

            string badText = "abc";
            bool bad_converted = int.TryParse(badText, out int value);

            Console.WriteLine("convert string to int using int.TryParse");

            if (bad_converted)

            {
                Console.WriteLine(value);

                Console.WriteLine("Conversion successful");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }


            #endregion
            #region Q9
            Console.WriteLine("-------Q9------ ");

            int page = 464;
            string pagetext = Convert.ToString(page);
            Console.WriteLine("convert int to string using Convert.ToString");
            Console.WriteLine(pagesText);
            Console.WriteLine(pagesText.GetType());

            #endregion

            #region Q10
            Console.WriteLine("-------Q10------ ");
            int copies = 100;
            object copies_num = copies;
            int copies_num2 = (int)copies_num;
            Console.WriteLine("before boxing");
            Console.WriteLine(copies);
            Console.WriteLine("after boxing");
            Console.WriteLine(copies_num);
            Console.WriteLine("after unboxing");
            Console.WriteLine(copies_num2);

            #endregion

            #endregion
            Console.WriteLine("---------------------------------------------------------------------------------------");

            Console.WriteLine("assignment 3");

            #region session 3
            #region Q1
            Console.WriteLine("-------Q1------ ");

            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine($"title: {title}");

            Console.WriteLine($"Upper case title: {upperTitle}");




            #endregion
            #region Q2
            Console.WriteLine("-------Q2------ ");
            string title2 = "clean code";
            string title3 = "clean code";
            Console.WriteLine(object.ReferenceEquals(title2,title3));


            #endregion
            #region Q3
            Console.WriteLine("-------Q3------ ");
            StringBuilder sb=new StringBuilder();
            sb.Append("Book List");
            sb.Append("- Updated");
            Console.WriteLine(sb);

            #endregion
            #region Q4
            Console.WriteLine("-------Q4------ ");
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Book Lis");
            sb1.Append("- Updated");
            Console.WriteLine(sb);
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb);
            #endregion
            #region Q5
            Console.WriteLine("-------Q5------ ");
            string title5 = "clean code";
            int pages5 = 464;
            string result = "book" + title5 + " has " + pages5 + " pages";
            Console.WriteLine(result);
            Console.WriteLine("-----------or-----------");
            Console.WriteLine("book"+title5+" has "+pages5+" pages");
            #endregion
            #region Q6
            Console.WriteLine("-------Q6------ ");
            string title6 = "clean code";
            int pages6 = 464;
            string result6 = $"book{title6} has {pages6} pages";
            Console.WriteLine(result6);
            Console.WriteLine("-----------or-----------");

            Console.WriteLine($"book{title6} has {pages6} pages");

            #endregion
            #region Q7
            Console.WriteLine("-------Q7------ ");
            string title7 = "clean code";
            int pages7 = 464;
            string result7 = string.Format("book{0} has {1} pages", title7, pages7);
            Console.WriteLine(result7);
            Console.WriteLine("-----------or-----------");
            Console.WriteLine(string.Format("book{0}has{1}pages", title7, pages7));
            #endregion

            #region Q8
            Console.WriteLine("-------Q8------ ");
            int pages8 = 464;
            if(pages8 >300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }

            #endregion

            #region Q9
            Console.WriteLine("-------Q9------ ");
            int pages9 = 464;
            bool isAvailable = true;
            // can also be written as if (pages9 > 300 && isAvailable)
            // becuase the default value of a boolean is true

            if (pages9>300 && isAvailable == true)
            { Console.WriteLine("Book is long and available to borrow ");
            }
            else
            {
                Console.WriteLine("Book is short or not available to borrow");
            }
            #endregion
            #region Q10
            Console.WriteLine("-------Q10------ ");
            string title10 = "Refactoring";
            switch(title10)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                 case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;


            }

            #endregion
            #region Q11
            Console.WriteLine("-------Q11------ ");
            int pages11 = 464;
            string sizeLabel = pages11>300 ? "long book": "short book";
            Console.WriteLine(sizeLabel);

            #endregion
            #region Q12
            Console.WriteLine("-------Q12------ ");
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i}:{books[i]}");
            }
            #endregion
            #region Q13
            Console.WriteLine("-------Q13------ ");
            string[] books13 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int i2=0;
            while (i2 < books13.Length)
            {
                Console.WriteLine($"{i2}:{books13[i2]}");
                i2++;
            }

            #endregion
            #region Q14
            Console.WriteLine("-------Q14------ ");
            int i3 = 0;
            do
            {
                Console.WriteLine("Checking book..");
                i3++;
            }
            while (i3 < 3);

            #endregion
            #region Q15
            Console.WriteLine("-------Q15------ ");
            string[] books15 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books15)
            {
                Console.WriteLine(book);
                
            }
            #endregion
            #region Q16
            Console.WriteLine("-------Q16------ ");
            string[] books16 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach(string book16 in books16)
            {
                if(book16 == "Refactoring")
                {
                    //extra marks for using break 
                    Console.WriteLine("Found the book!");
                    break;
                }
                Console.WriteLine(book16); 
            }
            #endregion
            #region Q17
            Console.WriteLine("-------Q17------ ");
            string[] books17 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book17 in books17)
            {
                if (book17 == "The Pragmatic Programmer")
                {
                    //extra marks for using  continue

                    Console.WriteLine("the book skipped!");
                    continue;
                }
                Console.WriteLine(book17);
            }
            #endregion
            #region Q18
            Console.WriteLine("-------Q18------ ");
            string[] books18 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            
            static void PrintFirstBook (string[] books18)

            {
                if (books18.Length > 0)
                {
                    Console.WriteLine($"{books18[0]}");
                }
                else
                {
                    Console.WriteLine("No books available.");
                    return;
                }
            }
            PrintFirstBook(books18);
            #endregion
            #endregion



        }
    }
}
