using SalesLibrary;

var custCtrl = new CustomersController("localhost", "sqlexpress");

var customers = custCtrl.GetAll();

var customerByCityAndSales = from c in customers
                             where (c.City == "Cincinnati" && c.Sales < 50000)
                           || (c.City == "Cleveland" && (c.Sales < 20000 || c.Sales > 50000))
                           || (c.City == "Columbus" && c.Sales < 40000)
                             orderby c.City, c.Sales
                             select c;

//var customersByName = customers.
//                      Where(x => x.City == "Cincinnati" && x.Sales < 50000
//                            || x.City == "Columbus" && x.Sales < 40000
//                             || x.City == "Cleveland" && (x.Sales < 20000 || x.Sales > 50000))
//                      .OrderBy(x => x.City)
//                      .ThenBy(x => x.Sales);

foreach (var c in customerByCityAndSales)
{
    Console.WriteLine($"{c.Id,2} | {c.Name,-20} | {c.City,-20}, {c.State} | {c.Sales,9:C} | {c.Active}");
}















//int[] nbrs = {

//   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,

//   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,

//   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,

//   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,

//   435, 643, 809, 874, 906, 620, 328, 369, 426, 561

//};

//nbrs.Min();
//nbrs.Max();
//nbrs.Average();
//var DivByThree = nbrs.Where(n => n % 3 == 0);
//var divBy3 = from i in nbrs
//             where i % 3 == 0 || i % 5 == 0
//             orderby i descending
//             select i;

//var divby3Or5 = nbrs.Where(i => i % 3 == 0 || i % 5 == 0).OrderBy(i => i).ToList();

//foreach(var i in nbrs)
//{
//    Console.WriteLine($"{i} ");
//}

//Console.WriteLine(DivByThree);
