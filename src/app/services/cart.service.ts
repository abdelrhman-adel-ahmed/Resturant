import { Injectable } from '@angular/core';
import { Meal } from '../models/Meal';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CartService {
  private cart: Meal[] = [];
  private apiUrl = 'https://localhost:7241/api/orders';

  constructor(private http: HttpClient) { }
  
  submitCart(cart: Meal[]): Observable<any> {
    return this.http.post(this.apiUrl+"", cart);
  }
  addToCart(meal: Meal): void {
    debugger;
    let cart = JSON.parse(localStorage.getItem('cart') || '[]');
    cart.push(meal);
    localStorage.setItem('cart', JSON.stringify(cart));
  }

  getCart(): Meal[] {
    return JSON.parse(localStorage.getItem('cart') || '[]');
  }

  clearCart(): void {
    localStorage.removeItem('cart');
  }
}