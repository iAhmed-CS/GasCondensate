import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './material/material.module';
import { ToolbarComponent } from './components/toolbar/toolbar.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { DisplayGasCondensateComponent } from './components/display-gas-condensate/display-gas-condensate.component';
import { UpdateGasCondensateComponent } from './components/update-gas-condensate/update-gas-condensate.component';
import { CreateGasCondensateComponent } from './components/create-gas-condensate/create-gas-condensate.component';

export const appRoutes: Routes = [
  { path: '', redirectTo:'home', pathMatch:'full' }, 
  { path: '', component: DisplayGasCondensateComponent }, 
  { path: 'add', component: CreateGasCondensateComponent },
  { path: 'update/:id', component: UpdateGasCondensateComponent },  
]


@NgModule({
  declarations: [
    AppComponent,
    ToolbarComponent,
    DisplayGasCondensateComponent,
    CreateGasCondensateComponent,
    UpdateGasCondensateComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MaterialModule,
    HttpClientModule,
    FontAwesomeModule,
    FormsModule,
    RouterModule.forRoot(appRoutes, {enableTracing: true}),
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
