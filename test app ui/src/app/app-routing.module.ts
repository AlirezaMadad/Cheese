import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CheeseListComponent } from './components/cheese-list/cheese-list.component';

const routes: Routes = [
  { path: '', redirectTo: 'list', pathMatch: 'full' },
  { path: 'list', component: CheeseListComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
