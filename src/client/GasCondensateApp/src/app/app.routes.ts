import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateGasCondensateComponent } from './components/create-gas-condensate/create-gas-condensate.component';
import { AppComponent } from './app.component';

export const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: AppComponent},
    { path: 'create-gas-condensate', component: CreateGasCondensateComponent }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
