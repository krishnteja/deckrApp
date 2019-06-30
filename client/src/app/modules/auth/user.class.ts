export interface User {
    id: number;
    name: string;
    email: string;
    hashedPassword: string;
    salt: string;
    createdAt: string;
	updatedAt: string;
}