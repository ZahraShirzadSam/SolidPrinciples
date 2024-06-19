using OCP_Principle;

ProductType1 p1 = new ProductType1();
p1.Name = "P1";
p1.Price = 1000;

Console.WriteLine(p1.GetDiscount);

Console.ReadKey();