Team name: FullStackDeveloper

Team members: Neelesh Maharjan

# Introduction

BookBase is a web-based knowledge-management platform for organizing and retrieving insights from books. Users will be able to browse a centralized library, search by title, author, language, genre, or tag, and open Q&A pairs about each book. Unlike a basic catalog, BookBase is designed around post-reading retention.

The project addresses a common problem. Reading notes are usually scattered across notebooks, documents, and separate apps, which makes it slow to find something previously learned. BookBase will store structured book information in one searchable place, using a React front end, a .NET 8 REST API, and a PostgreSQL database.

# Anticipated Technologies

Front end: The user interface will be built with React and Vite. React lets me reuse components like book cards and detail pages, and Vite keeps development fast. Fluent UI will provide accessible, ready-made controls. React Router will handle navigation. Redux will manage shared global application state, and Redux Saga will handle asynchronous tasks and side effects such as API requests. Axios will handle communication with the server.

Back end: The server will be a .NET 8 REST API that provides books, quotes, and Q&A pairs. It will implement a layered (Onion) architecture that separates domain models and service contracts from infrastructure concerns (persistence and presentation). Its primary responsibilities will be storing and querying book records in PostgreSQL, offering application services for business use cases, and exposing those services through a presentation layer (API).

Database: Data will be stored in PostgreSQL. For database access, I will use Dapper, which works best for hand-tuned SQL.

# Method/Approach

BookBase will be built in nine steps, starting with the data and moving outward to the user interface.

1. Design the database schema: Define a PostgreSQL schema for books, descriptions, quotes, and Q&A pairs, and the relationships between them. Every later layer builds on this foundation.

2. Extract book content with Claude: Use Claude to pull a description, notable quotes, and Q&A pairs from a book, then load them into the database to provide real data early.

3. Create the .NET project with Onion architecture: Set up a layered .NET 8 solution with domain entities at the center, then the application layer, then infrastructure and API. Dependencies point inward, keeping business logic independent and testable.

4. Connect .NET to PostgreSQL: Implement repositories in the infrastructure layer using Npgsql, behind interfaces defined in the inner layers.

5. Build the APIs: Create REST endpoints for books, quotes, and Q&A pairs, with search, filtering, and validation.

6. Test the back end: Write unit tests for business logic and integration tests against PostgreSQL to verify queries and endpoints.

7. Create the React front end: Set up a React and Vite app with an organized folder structure for components, pages, and services. Add Redux to hold shared state (books, quotes, loading, and errors) and Redux Saga to manage asynchronous API calls, cancellation, and failure handling.

8. Integrate with the API: Connect the interface so users can browse, search, and view books, quotes, and Q&A pairs, with clear loading and error states.

9. Test the front end: Test components, state logic, and key user workflows, and check responsiveness and accessibility.

# Estimated Timeline

The project has three major milestones. First, I'll design the database schema and load it with content extracted from a book using Claude, which should take about one week (by 10/7/2026). Second, I'll build the .NET back end, including the database connection, web APIs, and tests, which should take two to three weeks (by 10/28/2026). Third, I'll build the React front end and integrate it with the APIs, which should take another two to three weeks (by 11/15/2026).

# Anticipated Problems

1. Copyright issues when extracting book content: Using Claude to extract summaries, quotes, and Q&A pairs from books could run into copyright limits. Claude may decline to reproduce long passages from copyrighted books, and storing large amounts of copyrighted text in the database could create legal problems for the application.

2. Implementing Redux and Redux Saga: Redux and Redux Saga add complexity to the front end. Setting up the store, actions, reducers, and sagas involves a fair amount of boilerplate, and Saga's generator functions and asynchronous flow (such as cancellation and error handling) can be hard to learn and debug.
