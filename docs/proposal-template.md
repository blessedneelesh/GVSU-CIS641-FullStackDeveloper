Team name: FullStackDeveloper

Team members: Neelesh Maharjan

# Introduction

Mid-size dealerships often run sales, purchasing, banking and reporting through separate spreadsheets and paper files, leading to slow month-end closes (3–5 days), unreliable vehicle costing, missed collections, and no timely view of company finances.

This project proposes a centralized dealership accounting system to solve these problems by bringing sales, inventory, banking and reporting into one integrated platform with a single source of truth.

Key capabilities include: creating and managing sales invoices with automatic total calculations; recording partial/full payments to track customer balances; logging vehicle purchases and automatically marking units as Sold once invoiced — preventing double-selling; linking bank transactions to invoices for faster reconciliation; and providing monthly Profit & Loss reports, per-vehicle profit tracking, and a real-time financial dashboard.

By unifying these workflows, the system will reduce manual reconciliation effort, eliminate costly inventory errors, improve collections, and give management timely, accurate financial visibility.

# Anticipated Technologies

Front end: The user interface will be built with React and Vite. React lets me reuse components like invoice forms and vehicle detail views, and Vite keeps development fast. Fluent UI will provide accessible, ready-made controls. React Router will handle navigation. Redux will manage shared global application state, and Redux Saga will handle asynchronous tasks and side effects such as API requests. Axios will handle communication with the server.

Back end: The server will be a .NET 8 REST API that provides sales invoices, vehicle inventory, payments, and reporting data. It will implement a layered (Onion) architecture that separates domain models and service contracts from infrastructure concerns (persistence and presentation). Its primary responsibilities will be storing and querying accounting records in PostgreSQL, offering application services for business use cases (invoicing, payments, reconciliation), and exposing those services through a presentation layer (API).

Database: Data will be stored in PostgreSQL. For database access, I will use Dapper, which works best for hand-tuned SQL.

# Method/Approach

AutoPlex Motors Accounting System will be built in nine steps, starting with the data and moving outward to the user interface.

1. Design the database schema: Define a schema for vehicles, customers, invoices, payments, vendors and bank transactions, along with the relationships between them (e.g., a vehicle linked to one purchase record and one sales invoice). Every later layer builds on this foundation.

2. Load core reference data: Populate the database with initial vehicle inventory, vendor records and customer data to provide real data early and validate that the schema supports actual dealership workflows.

3. Create the back-end project with layered architecture: Set up a layered solution with domain entities (vehicle, invoice, payment) at the center, then application logic, then infrastructure and API. Dependencies point inward, keeping accounting rules independent and testable.

4. Connect the back end to the database: Implement repositories in the infrastructure layer for vehicles, invoices, payments and bank transactions, behind interfaces defined in the inner layers.

5. Build the core APIs: Create REST endpoints for vehicle purchases, sales invoices, payments and bank reconciliation, including validation (e.g., blocking a Sold vehicle from being invoiced again) and automatic calculations (invoice totals, balances due).

6. Test the back end: Write unit tests for business rules — invoice total calculations, Sold-status locking, balance updates on partial payment — and integration tests to verify database queries and API endpoints behave correctly.

7. Create the front end: Set up a web front end with an organized structure for screens covering sales invoicing, inventory, payments and reporting. Use shared state management to hold invoices, vehicle status, and loading/error states across the app.

8. Integrate with the API: Connect the interface so salespeople can create and manage invoices, accountants can record payments and reconcile bank transactions, and the dealership principal can view the dashboard and Profit & Loss reports — with clear loading and error states throughout.

9. Validate with accounting staff, then test the front end: Have accountants verify that calculations (balances, invoice totals, gross profit) are correct before the reporting screens are finalized. Then test components, workflows (invoice-to-payment, purchase-to-sale), and check responsiveness and accessibility.

# Estimated Timeline

The project has three major milestones. First, I'll design the database schema and load it with core reference data (vehicles, customers, vendors), which should take about two to three weeks (by 10/21/2026). Second, I'll build the back end, including the database connection, core APIs (invoicing, payments, inventory, bank reconciliation) and tests, which should take two to three weeks (by 11/11/2026). Third, I'll build the front end, integrate it with the APIs, and validate calculations with accounting staff, which should take another two weeks (by 11/25/2026).

# Anticipated Problems

1. Linking sales and purchase records: A vehicle's purchase record and sales invoice must stay correctly linked so gross profit and Sold status stay accurate. An incorrect link could let a unit be re-invoiced or produce wrong profit figures.

2. Bank reconciliation matching: Matching bank transactions to invoices and bills is complex due to partial payments, fees, and timing differences. Faulty matching logic could undermine the reconciliation feature's goal of speeding up month-end close.
