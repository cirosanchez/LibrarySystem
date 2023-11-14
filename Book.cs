

namespace LibrarySystem {
    public class Book {
        private String title;
        private int pagesNum;
        private string editorial;
        private int id;
        private string author;

        public Book(string title, int pagesNum, string editorial, int id, string author) {
            this.title = title;
            this.pagesNum = pagesNum;
            this.editorial = editorial;
            this.id = id;
            this.author = author;
        }
        public void displayData() {
            Console.WriteLine("Title: "+title);
            Console.WriteLine("# of pages: "+pagesNum);
            Console.WriteLine("Editorial: "+editorial);
            Console.WriteLine("ID: "+id);
            Console.WriteLine("Author: "+author);
        }
    }
}
