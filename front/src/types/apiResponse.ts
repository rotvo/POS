export interface PaginatedResponse<T> {
  totalRecords: number;
  items: T[];
}

export interface ApiResponse<T> {
  data: PaginatedResponse<T>;
}