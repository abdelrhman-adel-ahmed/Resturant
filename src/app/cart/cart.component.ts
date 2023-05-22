import { Component } from '@angular/core';
import { Meal } from '../models/Meal';
import { MealService } from '../services/meal.service';
import { CartService } from '../services/cart.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent {
  cart: Meal[] = [];
  submitted = false;
  constructor(private cartService:CartService) {}

  ngOnInit(): void {
    this.cart = this.cartService.getCart();
  }

  submitCart(): void {
    this.cartService.submitCart(this.cart).subscribe({
      next: () => {
        this.submitted = true;
        this.cartService.clearCart();
      },
      error: (error) => {
        console.log(error);
      }
    });
  }
}
