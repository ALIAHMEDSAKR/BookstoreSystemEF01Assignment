using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreSystemEF01Assignment.Models
{
    /*
        Q1: Why did the property "Id" become a Primary Key
        without any explicit configuration?

            This happens because of a core Entity Framework feature called Mapping by Convention,
            which is EF Core's default behavior. When EF Core scans your classes, it looks for specific naming patterns.
            If it finds a property named exactly Id (or <ClassName>Id, like AuthorId),
            it automatically configures it as the Primary Key. Furthermore, because the property is an integer (int),
            EF Core will automatically set it up as an Identity column (auto-incrementing) in the SQL Server database

        Q2: Why is "Country" nullable in the database
        while "Price" is not?

            This Because how C# handles different data types and how EF Core translates them:
            Country (string?): In C#, adding the question mark (?) explicitly marks the property as a nullable type. 
            EF Core reads this syntax and understands that this field is optional,
            translating it into a nullable column in the database.
            Price (decimal): A decimal in C# is a Value Type.
            By definition, value types cannot hold a null value unless explicitly instructed to do so;
            they must always contain data. Because it cannot be null,
            EF Core strictly maps it as a Required (NOT NULL) column in the database.
            If you wanted the database to accept nulls for the price, you would have to define it as decimal? in your C# code.
     */
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}
