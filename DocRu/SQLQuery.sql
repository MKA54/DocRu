Use DocRu;

-- ������ �����������, ������� ���� ������� �� ���� ���� ��� �� ����� 
Select car.Name 
From Cars as car
Where car.BaseID IS NOT NULL AND car.BrandID = (Select c.BrandID
										From Cars AS c
										WHERE c.ID = car.BaseID)

-- ������ �����, ������� �������� ������ 3 �����������
Select Brands.Name
From Brands
Join Cars
On Brands.ID = Cars.BrandID
Group By Brands.Name
Having COUNT(Cars.Name) > 3;

-- ������ ����� � ����������� ������ �� ������� ����� ���������� ����
Select Brands.Name, SUM(Cars.Price) as amount_cars_cost
From Brands
Join Cars
On Brands.ID = Cars.BrandID
Group By Brands.Name
Order BY amount_cars_cost DESC;

-- ������ ���� ����� � ������������ ������� ��������� ����������� 
Select TOP 2 Countries.Name, AVG(Pow) as avg_pow
From Countries
Join Brands
On Countries.ID = Brands.CountryID
Join Cars
On Brands.ID = Cars.BrandID
Group By Countries.Name
Order BY avg_pow DESC;

-- ������ ����� ������� ����������� ������ ����� 
Select Brands.Name AS brand_name, Cars.Name AS car_name
From Brands
Join Cars
On Brands.ID = Cars.BrandID
Where Price = (Select MIN(Price)
					From Cars
					Join Brands AS br
					On br.ID = Cars.BrandID
					Where brands.Name = br.Name)
