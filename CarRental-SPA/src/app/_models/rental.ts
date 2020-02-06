import { Car } from './car';
import { User } from './user';

export interface Rental {
  id: number;
  cars: Car;
  users: User;
  startDate: Date;
  endDate: Date;
}
