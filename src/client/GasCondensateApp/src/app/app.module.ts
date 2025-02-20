import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { CreateGasCondensateComponent } from './components/create-gas-condensate/create-gas-condensate.component';
import { AppRoutingModule } from './app.routes';

@NgModule({
  declarations: [
    AppComponent,
    CreateGasCondensateComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
