Use DocRu;

-- Список автомобилей, которые были созданы на базе авто той же марки 
Select car.Name 
From Cars as car
Where car.BaseID IS NOT NULL AND car.BrandID = (Select c.BrandID
										From Cars AS c
										WHERE c.ID = car.BaseID)

-- Список марок, которые содержат больше 3 автомобилей
Select Brands.Name
From Brands
Join Cars
On Brands.ID = Cars.BrandID
Group By Brands.Name
Having COUNT(Cars.Name) > 3;

-- Список марок с необходимой суммой на покупку всего модельного ряда
Select Brands.Name, SUM(Cars.Price) as amount_cars_cost
From Brands
Join Cars
On Brands.ID = Cars.BrandID
Group By Brands.Name
Order BY amount_cars_cost DESC;

-- Список двух стран с максимальной средней мощностью автомобилей 
Select TOP 2 Countries.Name, AVG(Pow) as avg_pow
From Countries
Join Brands
On Countries.ID = Brands.CountryID
Join Cars
On Brands.ID = Cars.BrandID
Group By Countries.Name
Order BY avg_pow DESC;

-- Список самых дешевых автомобилей каждой марки 
Select Brands.Name AS brand_name, Cars.Name AS car_name
From Brands
Join Cars
On Brands.ID = Cars.BrandID
Where Price = (Select MIN(Price)
					From Cars
					Join Brands AS br
					On br.ID = Cars.BrandID
					Where brands.Name = br.Name)
