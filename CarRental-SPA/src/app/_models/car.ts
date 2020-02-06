import { Photo } from './photo';

export interface Car {
  id: number;
  manufacturer: string;
  type: string;
  licensePlateNumber: string;
  averageConsumption: number;
  color: string;
  fuel: string;
  numberOfPassengers: number;
  photoUrl: string;
  photos?: Photo[];
}
