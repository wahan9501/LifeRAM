// See https://aka.ms/new-console-template for more information

using LifeRAM.Core;
using Microsoft.EntityFrameworkCore;

using var ramDbContext = new RAMDbContext(new DbContextOptionsBuilder<RAMDbContext>()
    .UseInMemoryDatabase("InMemoryDatabase")
    .Options);

Console.WriteLine(ramDbContext.RAM.ToList().Count);

var newRAM = new RAM
{
    StartDateTime = DateTimeOffset.Now,
    Length = TimeSpan.FromMinutes(5)
};

ramDbContext.RAM.Add(newRAM);
ramDbContext.SaveChanges();

Console.WriteLine(ramDbContext.RAM.ToList().Count);

using var ramDbContext2 = new RAMDbContext(new DbContextOptionsBuilder<RAMDbContext>()
    .UseInMemoryDatabase("InMemoryDatabase")
    .Options);

Console.WriteLine(ramDbContext2.RAM.ToList().Count);

Console.WriteLine("Hello, World!");