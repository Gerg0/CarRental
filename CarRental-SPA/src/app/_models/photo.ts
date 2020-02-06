import { Car } from './car';

export interface Photo {
  id: number;
  url: string;
  isMain: boolean;
  car: Car;
  carId: number;
}
