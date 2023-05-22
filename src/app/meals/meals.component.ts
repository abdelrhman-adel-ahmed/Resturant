import { Component } from '@angular/core';
import { MealService } from '../services/meal.service';
import { Meal } from '../models/Meal';
import { CartService } from '../services/cart.service';

@Component({
  selector: 'app-meals',
  templateUrl: './meals.component.html',
  styleUrls: ['./meals.component.css']
})
export class MealsComponent {
   meals: Meal[];
  cartSize: number;

  constructor(private mealService: MealService, private cartService: CartService){}

  ngOnInit(): void {
    this.mealService.getMeals().subscribe((meals) => {
      this.meals = meals;
    });
    this.cartSize = this.cartService.getCart().length;
  }

  addToCart(meal:Meal) {
    this.cartService.addToCart(meal);
  }

}
