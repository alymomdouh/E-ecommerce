## Course Learn to build e-commerce using Angular and .NET core Arabic In Udemy 
<a href="https://www.udemy.com/course/learn-to-build-e-commerce-using-angular-and-net-core-arabic/learn/lecture/36948084#learning-tools">link</a>
## Course content
### Section 1: Introduction 
1. Introduction 
2. Setting up the developer environment
3. setting up vs code for c# environment
c# , c# Extensions ,Material Icon Theme ,NuGet Gallery ,SQLite
## Section 2: API Introduction
4. Introduction
5. Creating API Project
###### > Dotnet -info
###### > dotnet --help
###### > Dotnet -h
###### > Dotnet new sln -n E-ecomerce
###### > Dotnet new webapi -n API
###### > Dotnet sln add API 
###### >code .
6. Running the API using the DotNet CLI
###### ....\myProject\API>dotnet run
http://localhost:5204/WeatherForecast
7. Adding our first API Controller
8. Adding a C# Entity class
9. Setting up Entity Framework
install Microsoft.EntityFrameworkCore
install Microsoft.EntityFrameworkCore.Sqlite
install Microsoft.EntityFrameworkCore.Design
10. Adding Connection String
11. Adding an Entity Framework migration
>dotnet tool update --global dotnet-ef        // this for windows 
#####  >cd API
#####  > dotnet ef migrations add initialCreate --context StoreContext --output-dir Data/Migrations
12. Updating the database
#####  >cd API
#####  >dotnet ef database update
13. Reading the data from the Database in the API
14. Creating the new additional Projects
-create new project as class libraries (Core,Infrastrucure)
and put entities in Core and data or DbContext in Infrastrucure
### Section 3 :API Structure 
15. Adding a Repository and Interface
16. Adding the repository methods
17. Extending the products entity and creating related entities
18. Creating a new migration for the entities
delete folder 📂 that contain all migrations  then run command
 
 #####  >dotnet ef migrations add initialCreate -p Infrastrucure -s API  --context StoreContext --output-dir Data/Migrations
19. Configuring the migrations
delete folder 📂 that contain all migrations  then run command
 
 #####  >dotnet ef migrations add initialCreate -p Infrastrucure -s API  --context StoreContext --output-dir Data/Migrations
#####  >dotnet ef database update
20. Applying the migrations and creating the Database at app startup 
21. Adding Seeding data
22. Adding the code to get the product brands and types
23. Eager loading of navigation properties
### Section 4 API Generic Repository 
24. Creating a Generic repository and interface
25. Implementing the methods in the Generic reposi…
26. Creating a specification class
27. Creating a specification evaluator
28. Implementing the repository with specification method
29. Using the specification methods in the controller
30. Getting a single product with specification
31. Shaping the data to return with DTOs
32. Adding AutoMapper to the API project 
33. Configuring AutoMapper profiles
34. Adding a Custom Value Resolver for AutoMapper
35. Serving static content from the API
## Section 5 :API Complete Error Handling 
36. Creating a test controller for errors
37. Creating a consistent error response from the API
38. Adding a not found endpoint error handler
39. Creating Exception handler middleware
## Section 6 : API Paging Filtering Sorting Searching 
40. Adding a sorting specification class
41. Adding a sorting specification part 2
42. Working around the decimal problem in Sqlite
43. Adding filtering functionality
44. Adding Pagination Part 1
45. Adding Pagination Part 2 
46. Adding Pagination Part 3
47. Adding the search functionality
48. Adding CORS Support to the API
### section 7  client angular setup environment 
49. Setting up the developer environment for Angular 
after install all 
    > node -v 
    
    > ng --version 
50. Creating the Angular project
>ng new Client 
 
> ng serve 
51. Reviewing the Angular project files in the template 
52. Adding bootstrap and font-awesome
53. Adding VS Code extensions for Angular



