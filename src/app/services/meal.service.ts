import { Injectable } from '@angular/core';
import { Meal } from '../models/Meal';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MealService {
  private apiUrl = 'https://localhost:7241/api/meals';

  constructor(private http: HttpClient) { }

  getMeals(): Observable<Meal[]> {
    return this.http.get<Meal[]>(this.apiUrl+"");
  }
}
