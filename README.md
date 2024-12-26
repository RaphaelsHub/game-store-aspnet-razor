# game-store-aspnet-razor
Educational project for learning how ASP.NET Razor Pages and how Frontend and Backend interact among each other.

## Technologies
- **Backend**: ASP.NET Razor Pages
- **Frontend**: HTML, CSS, JavaScript (used as a template)

## Getting Started
1. Clone the repository: `git clone https://github.com/RaphaelsHub/game-store-aspnet-razor.git`
2. Restore dependencies: `dotnet restore`
3. Note: This project does not use a database. Instead, a class will serve as the storage.
4. Run the project: `dotnet run`


## How to transfer data from frontend to backend and how to call methods
I learned how to call methods in Razor Pages:  

1. **HTTP Method**:  
   - For a POST method, specify `method="post"`.  
   - For a GET method, specify `method="get"`.  

2. **Calling Static Pages**:  
   - Use the `asp-page` attribute to reference the page:  
     ```html
     <a asp-page="/PageName">Go to Page</a>
     ```

3. **Passing Data to Pages**:  
   - Use `asp-route-{variable}` to pass data via route parameters:  
     ```html
     <a asp-page="/PageName" asp-route-id="123">Details</a>
     ```

4. **Calling Methods from PageModel**:  
   - Use `asp-page-handler` to specify the method (handler) to call:  
     ```html
     <form method="post" asp-page-handler="Submit">
         <input type="text" name="Name" />
         <button type="submit">Submit</button>
     </form>
     ```  
   - This will invoke the corresponding handler in the PageModel, such as `OnPostSubmit()`.

## License
Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International (CC BY-NC-ND 4.0) License

© 2024 Pekel Alexandr Alexei

You are free to:
- Share — copy and redistribute the material in any medium or format

Under the following terms:
- Attribution — You must give appropriate credit, provide a link to the license, and indicate if changes were made.
- NonCommercial — You may not use the material for commercial purposes.
- NoDerivatives — If you remix, transform, or build upon the material, you may not distribute the modified material.

No additional restrictions — You may not apply legal terms or technological measures that legally restrict others from doing anything the license permits.
