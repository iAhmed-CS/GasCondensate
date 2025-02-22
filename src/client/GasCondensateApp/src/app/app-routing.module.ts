import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DisplayGasCondensateComponent } from './components/display-gas-condensate/display-gas-condensate.component';

const routes: Routes = [
  { path: '', redirectTo:'home', pathMatch:'full' }, 
  { path: 'home', component: DisplayGasCondensateComponent }, 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
