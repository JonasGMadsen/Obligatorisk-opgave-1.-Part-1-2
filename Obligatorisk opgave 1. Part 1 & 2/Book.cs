namespace Obligatorisk_opgave_1._Part_1___2
{
    public class Book
    {
        public int id { get; set; }
        public string? title { get; set; }
        public int price { get; set; }

        public override string ToString()
        {
            return $"Id: {id}, Title: {title}, Price: {price}";
        }

        public void ValidateTitle()
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("Title cannot be null");
            }

            if (title.Length < 2)
            {
                throw new ArgumentException("Title must be at least 2 characters");
            }
        }


        public void ValidatePrice()
        {
            if (price <= 0 || price >= 1200)
            {
                throw new ArgumentException("Price must be above 0 or under 1200");
            }
        }

        public void Validate()
        {
            ValidateTitle();
            ValidatePrice();
        }
    }
}