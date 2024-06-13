# GameZone - ASP.NET Core using RAWG API

GameZone is an ASP.NET Core MVC web application that lists game information and displays game details using the RAWG API.

![image](https://github.com/karabasnejat/GameZone/assets/62561906/63790290-f7b7-4cfc-82ef-bbdae5170d4d)
![image](https://github.com/karabasnejat/GameZone/assets/62561906/ad747b0f-4f41-4bb5-84a3-51e4959befd9)
![image](https://github.com/karabasnejat/GameZone/assets/62561906/502ffd1e-95d9-468d-b319-6ce03b36d707)

## Features

- Listing trending games on the homepage
- Displaying game details including description, images, rating, platforms, and stores on the game detail page
- Clickable game images with Lightbox integration
- Responsive sidebar menu

## Technologies

- **ASP.NET Core 7.0**: Backend services and API development.
- **Entity Framework Core**: Efficient data management and ORM.
- **Ocelot API Gateway**: Secure routing between microservices.
- **Tailwind CSS**: Modern, responsive design framework.
- **Node.js**: Additional backend services and utilities.
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

5. Open the following URL in your browser:

    ```
    https://localhost:5001
    ```

## Usage

- You can see trending games on the homepage.
- Click on game titles to access their detail pages.
- On the detail page, click on game images to view them in full size.

## Contributing

If you would like to contribute, please send a pull request. You can also open an issue for any bugs or suggestions.

## License

This project is licensed under the MIT License. For more information, see the `LICENSE` file.
