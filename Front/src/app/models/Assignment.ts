export interface Assignment {
    id: number;
    title: string;
    description: string;
    createdAt: Date;
    updatedAt: Date;
    projectId: number;
    isCompleted: boolean;
}