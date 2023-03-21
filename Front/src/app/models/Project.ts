import { Assignment } from "./Assignment";

// export an interface called Project
export interface Project {
    // define the properties of the project
    id: number;
    title: string;
    description: string;
    createdAt: Date;
    updatedAt: Date;
}

export interface FullProject extends Project {
    // define the properties of the project      
    assignments: Assignment[];
    ownerId: number;
    participators: any[];
}
