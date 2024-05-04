import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';
import { BudgetModel } from './budget.model';

@Injectable({
  providedIn: 'root'
})
export class BudgetService {

  constructor(private http: HttpClient) { }

  url: string = 'https://localhost:7216/api/budgets';
  urlToGetIdByName: string = 'https://localhost:7216/api/Budgets/byname';
  urlToGetBudgetsById: string = 'https://localhost:7216/api/UserBudgets/api/budgets/byuser';
  list: BudgetModel[] = [];
  clickedBudget: BudgetModel = new BudgetModel;
  newBudgetId: number = 0;

  budgetData: BudgetModel = new BudgetModel();

  addBudget(name: string, description: string) {
    const budgetData = {
      budgetId: 0,
      name: name,
      description: description,
      userBudgets: [],
      incomes: [],
      expenditures: [],
      payments: []
    };
    return this.http.post(this.url, budgetData);

  }

  getBudgets(id: number) {
    const url = `${this.urlToGetBudgetsById}/${id}`; // Zmodyfikowany URL z przekazanym id
    this.http.get<BudgetModel[]>(url) // Zakładam, że oczekiwany typ to BudgetModel[]
    .subscribe({
        next: res => {
            this.list = res; // Przypisanie odpowiedzi do listy, zakładając, że odpowiedź jest już typu BudgetModel[]
            console.log(res);
        },
        error: err => {
            console.error('Error fetching budgets:', err);
        }
    });
}

  getUserIdByName(name: string): Observable<number> {
    return this.http.get<number>(`${this.urlToGetIdByName}/${name}`);
  }

  setBudgetId(id: number) {
    this.newBudgetId = id;
  }

///////////////////////////////////////////////////////////////// Pobiera jeden budżet po podaniu id tego budżetu
  getSingleBudget(id: number) {
    const url = `${this.url}/${id}`; // Zmodyfikowany URL z przekazanym id
    this.http.get<BudgetModel>(url) // Zakładam, że oczekiwany typ to BudgetModel[]
    .subscribe({
        next: res => {
            this.clickedBudget = res; // Przypisanie odpowiedzi do listy, zakładając, że odpowiedź jest już typu BudgetModel[]
            console.log(res);
        },
        error: err => {
            console.error('Error fetching budgets:', err);
        }
    });
  }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
getBudgetName(budgetId: number): Observable<string> {
  return this.http.get<{ name: string }>(`${this.url}/${budgetId}`).pipe(
    map(response => response.name)
  );
}
}
