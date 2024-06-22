# GameZone - ASP.NET Core using RAWG API

GameZone is an ASP.NET Core MVC web application that lists game information and displays game details using the RAWG API.

![image](https://github.com/karabasnejat/GameZone/assets/62561906/70de9fdc-568a-494d-a034-ae58f064c958)
![image](https://github.com/karabasnejat/GameZone/assets/62561906/62197611-bb67-4254-b4ba-75018f55bcdd)
![image](https://github.com/karabasnejat/GameZone/assets/62561906/39215680-d2b9-4e4d-9e62-24cb80b29254)

## Features

- Listing trending games on the homepage
- Displaying game details including description, images, rating, platforms, and stores on the game detail page
- Clickable game images with Lightbox integration
- Responsive sidebar menu

## Technologies

- **ASP.NET Core 7.0**: Backend services and API development.
- **Entity Framework Core**: Efficient data management and ORM.
- **Bootstrap*: Modern, responsive design framework.
- **N-Tier Architecture**: Separates concerns across different layers, improving maintainability.

## Installation

To run this project locally, follow these steps.

### Requirements

- .NET 7.0 SDK
- Visual Studio or Visual Studio Code
- Git

### Steps

1. Clone the repository:

    ```bash
    git clone https://github.com/username/GameZone.git
    cd GameZone
    ```

2. Install the necessary dependencies:

    ```bash
    dotnet restore
    ```

3. Update the database and necessary configurations:

    - Configure the `appsettings.json` file.
    - Set your RAWG API key (check your key in the `GameService.cs` file).

4. Run the application:

    ```bash
    dotnet run
    ```


## Usage

- You can see trending games on the homepage.
- Click on game titles to access their detail pages.
- On the detail page, click on game images to view them in full size.

## Contributing

If you would like to contribute, please send a pull request. You can also open an issue for any bugs or suggestions.

## License

This project is licensed under the MIT License. For more information, see the `LICENSE` file.
