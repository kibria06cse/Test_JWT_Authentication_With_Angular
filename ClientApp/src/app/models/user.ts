export class User {
  userName: string;
  firstName: string;
  isLoggedIn: boolean;
  role: string;
}

export enum UserRole {
  Admin = 'Admin',
  User = 'User'
}  
