# Customer Management API

Welcome to the Customer Management API! This API serves as the backend component of a customer management system, providing essential functionality for user authentication and customer data management.

## Table of Contents

- [Customer Management API](#customer-management-api)
  - [Table of Contents](#table-of-contents)
  - [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Installation](#installation)
  - [API Documentation](#api-documentation)
    - [Accessing Swagger Documentation](#accessing-swagger-documentation)
  - [MySQL](#mysql)
  - [Why MySQL?](#why-mysql)
  - [Architecture Pattern: MVC and SOLID Principles](#architecture-pattern-mvc-and-solid-principles)
    - [MVC (Model-View-Controller)](#mvc-model-view-controller)
    - [Relationship with SOLID Principles](#relationship-with-solid-principles)
  - [Gitmoji Commit Convention](#gitmoji-commit-convention)
    - [Gitmoji vs. Semantic Commits](#gitmoji-vs-semantic-commits)
      - [Gitmoji](#gitmoji)
      - [Semantic Commits](#semantic-commits)
      - [Advantages of Gitmoji](#advantages-of-gitmoji)
  - [License](#license)
  - [Next Steps](#next-steps)

## Getting Started

To get started with the Customer Management API, follow these steps:

### Prerequisites

Before you begin, ensure that you have the following prerequisites installed on your system:

- [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [Docker](https://docs.docker.com/engine/install/)

### Installation

1. Clone the repository:

   ```sh
   git clone https://github.com/MiguelMDSDP/customer-management-api.git
   ```

2. Navigate to the project's root directory:

   ```sh
   cd CustomerManagementAPI
   ```

3. Run the docker-compose file

   ```sh
   docker-compose up -d
   ```

4. Create the migrations

   ```sh
   dotnet ef migrations add InitialMigration
   ```

5. Update the database

   ```sh
   dotnet ef database update
   ```

6. Build the project:

   ```sh
   dotnet build
   ```

7. Run the application:

   ```sh
   dotnet run
   ```

This will start the Customer Management API on your local machine. You can access it at <http://localhost:5000>.

For more detailed instructions on configuring and using the API, refer to the API Documentation section.

## API Documentation

A comprehensive API documentation is implemented for the Customer Management API using Swagger. Swagger provides a user-friendly interface for exploring and testing API endpoints. Here's why Swagger was chosen and how it benefits the project:

- **Interactive Documentation:** Swagger generates interactive documentation for the API, making it easy for developers to understand the available endpoints, request parameters, and response structures.

- **Testing and Debugging:** With Swagger, you can test API endpoints directly from the documentation interface. It's an excellent tool for debugging and ensuring that your API functions as expected.

- **Simplified Integration:** Swagger simplifies the integration of the API with client applications. Developers can refer to the documentation for accurate endpoint descriptions, reducing integration complexity.

- **Consistency:** By using Swagger, the API documentation remains up to date and consistent with the actual API implementation. This helps maintain a high level of accuracy.

### Accessing Swagger Documentation

To access the Swagger documentation for the Customer Management API, follow these steps:

1. Start the Customer Management API as described in the [Getting Started](#getting-started) section.

2. Open a web browser and navigate to [http://localhost:5000/swagger/index.html](http://localhost:5000/swagger/index.html).

3. You will be presented with the Swagger documentation interface, where you can explore and test the API's endpoints.

Feel free to use Swagger for testing and understanding the API's capabilities. If you have any questions or encounter any issues, refer to the documentation or reach out to the team for assistance.

## MySQL

## Why MySQL?

In the development of the application, the choice of the right database management system (DBMS) is a critical decision. MySQL was selected as the preferred DBMS for several compelling reasons:

1. **Open-Source:** MySQL is an open-source relational database management system, meaning it's freely available and can be used without incurring licensing costs. This aligns with the projetc's goal to keep the project cost-effective.

2. **Community Support:** MySQL boasts a vast and active user community. This extensive community support ensures the access to a wealth of resources, forums, and documentation to help troubleshoot issues, optimize performance, and find solutions quickly.

3. **Scalability:** MySQL is renowned for its scalability. As the application grows, a database that can handle increasing data volumes and traffic is needed. MySQL's ability to scale horizontally and vertically makes it a suitable choice for future expansion.

4. **Performance:** MySQL is known for its fast read and write operations, making it an excellent choice for applications that require quick data retrieval and storage. Its performance optimizations ensure responsive data access.

5. **Reliability:** MySQL is a proven and reliable DBMS that has been used successfully in numerous mission-critical applications across industries. Its robustness and data integrity features align with the commitment to delivering a dependable application.

6. **Compatibility:** MySQL is compatible with a wide range of programming languages, making it versatile for integration with various technologies, including the choice of the .NET ecosystem for the backend and ReactJS for the frontend.

7. **Security:** MySQL offers robust security features, including user authentication, role-based access control, encryption, and auditing capabilities. This helps us ensure the confidentiality and integrity of the users' data.

8. **Maturity:** MySQL has a long history and has been refined over the years. This maturity ensures stability and minimizes the risk of encountering unexpected issues or limitations.

In conclusion, MySQL was selected as the database system for the project due to its open-source nature, strong community support, scalability, performance, reliability, compatibility, security features, and proven track record. These factors collectively contribute to a solid foundation for the application's data storage and management needs.

## Architecture Pattern: MVC and SOLID Principles

### MVC (Model-View-Controller)

The Customer Management API follows the Model-View-Controller (MVC) architectural pattern to organize the structure of the application. This pattern divides the application into three main components:

- **Model:** Represents data and business logic. It manages the state of the application and responds to queries about this data.

- **View:** Responsible for presenting data to users and interacting with them. The View displays data from the Model in a user-friendly manner and may collect user inputs.

- **Controller:** Acts as an intermediary between the Model and the View. It receives user requests, handles the necessary business logic (usually in the Model), and updates the View with the results. The Controller also manages the application's control flow.

### Relationship with SOLID Principles

The use of the MVC pattern aligns with the principles of SOLID, particularly the Single Responsibility Principle (SRP) and the Interface Segregation Principle (ISP):

- **Single Responsibility Principle (SRP):** MVC helps maintain the single responsibility of each component. The Model is responsible for data and business logic, the View handles presentation and user interaction, and the Controller coordinates between the other two components. This promotes cohesion and makes it easier to identify and maintain each part of the application.

- **Interface Segregation Principle (ISP):** MVC also supports the idea of separating the interfaces of each component. Each component has a clear and defined interface for communicating with the others, making it easy to modify or replace one component without affecting the others.

By following the MVC pattern in the ASP.NET Core project, the code organization, maintainability, and extensibility are enhanced, aligning with SOLID software design principles.

## Gitmoji Commit Convention

The Gitmoji commit convention is used to provide a visual representation of the purpose and content of each commit. This convention helps us understand changes at a glance and maintain a clean commit history.

- :sparkles: `:sparkles:: Introducing new features
- :bug: `:bug:: Fixing a bug
- :art: `:art:: Improving code structure or format
- :rocket: `:rocket:: Deploying something
- :construction: `:construction:: Work in progress
- :memo: `:memo:: Writing documentation
- :fire: `:fire:: Removing code or files
- :tada: `:tada:: Initial commit
- and many more...

### Gitmoji vs. Semantic Commits

Both Gitmoji and Semantic Commits are commit message conventions that aim to provide a structured and informative commit history. Let's compare Gitmoji to Semantic Commits and discuss some advantages of using Gitmoji:

#### Gitmoji

- **Visual Representation:** Gitmoji uses emojis to visually represent the type of change made in a commit. For example, `:bug:` represents a bug fix, `:sparkles:` represents the introduction of a new feature, and so on. This visual representation makes it easy to quickly grasp the nature of a commit.

- **Rich Set of Emojis:** Gitmoji offers a wide range of emojis, each associated with a specific type of change. This richness allows for precise categorization of commits, such as `:construction:` for work in progress or `:memo:` for documentation changes.

- **Intuitive and Fun:** The use of emojis adds an element of fun to commit messages, making the commit history more engaging. It also makes it easier for team members to remember and adhere to the convention.

- **Customization:** Gitmoji is highly customizable, allowing teams to define their own emojis and meanings if needed. This flexibility ensures that the convention can be adapted to fit the project's specific requirements.

#### Semantic Commits

- **Semantic Meaning:** Semantic Commits use a predefined structure in commit messages, such as `<type>(<scope>): <description>`. The `<type>` typically represents the category of the change (e.g., `feat` for a new feature or `fix` for a bug fix).

- **Widely Adopted:** Semantic Commits have gained popularity and are widely adopted in the software development community. Many tools and platforms support semantic commit messages.

- **Consistency:** The structured format of Semantic Commits promotes consistency in commit messages, making it easier to automate tasks like version bumping and release notes generation.

#### Advantages of Gitmoji

1. **Visual Clarity:** Gitmoji provides a clear visual indication of the commit's purpose. This is especially valuable when quickly scanning commit logs or pull requests.

2. **Expressive and Playful:** Emojis add a touch of expressiveness and playfulness to commit messages, which can enhance collaboration and make the commit history more engaging.

3. **Easy Adoption:** Gitmoji is easy to adopt and remember, even for team members who may not be familiar with commit conventions. The emojis themselves convey meaning.

4. **Customization:** Teams can customize Gitmoji to align with their project's unique needs, allowing for flexibility in categorizing commits.

In summary, while both Gitmoji and Semantic Commits serve the purpose of providing structured commit messages, Gitmoji stands out for its visual clarity, expressiveness, and ease of adoption. It adds an enjoyable and informative layer to the commit history, making it a popular choice for teams looking to maintain a clean and meaningful version control history.

## License

This project is licensed under the MIT License.

## Next Steps

To continue improving the API, here are the next steps to take:

1. **Authentication Model in Database Context:** Add the authentication model to the database context to enable secure storage of user information and authentication-related data.

2. **Database Context Setup:** Ensure correct instantiation and management of the database context throughout the application. Implement a robust database context initialization strategy using Entity Framework Core, ensuring efficient data access.

3. **Controller Refactoring:** Refactor authentication and customer management controllers to use the database context for proper data persistence. Utilize Entity Framework Core's ORM capabilities for seamless data interactions.

4. **Role and Access Management:** Add role and access management capabilities to the API using a role-based access control (RBAC) system. Libraries like `AspNetCore.Identity` provide features for managing roles and permissions.

5. **Unit Testing:** Implement unit tests for the application's critical components and controllers using testing frameworks like `xUnit` or `NUnit`. Automated tests help ensure the reliability and functionality of the API.

6. **CI/CD Pipeline:** Establish a Continuous Integration and Continuous Deployment (CI/CD) pipeline using CI/CD services such as `GitHub Actions`, `Azure DevOps`, or `Travis CI`. Automate the deployment process for efficient and reliable releases.

These steps, along with their suggested solutions, represent the ongoing commitment to building a robust and feature-rich API.
