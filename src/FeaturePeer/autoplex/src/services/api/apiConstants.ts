// Calls the .NET API directly, so it must allow the frontend origin via CORS.
// Set VITE_CUSTOMER_API_URL=/ to go through the Vite dev proxy instead.
export const CUSTOMER_API_BASE_URL: string = import.meta.env.VITE_CUSTOMER_API_URL ?? 'https://localhost:7003/'

export const CUSTOMER_ENDPOINTS = {
  getAllCustomers: 'Customer/GetAllCustomers',
} as const
