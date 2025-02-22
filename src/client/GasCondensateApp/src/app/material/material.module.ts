import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatToolbarModule } from '@angular/material/toolbar'
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input'
import { MatTableModule } from '@angular/material/table'
import {MatDialogModule} from '@angular/material/dialog';
import { AgmCoreModule } from '@agm/core';

const MaterialComponents = [ 
  MatButtonModule,
  MatToolbarModule,
  MatIconModule,
  MatListModule,
  MatFormFieldModule,
  MatInputModule,
  MatTableModule,
  MatDialogModule,
  AgmCoreModule.forRoot({
    apiKey: 'AIzaSyDjZ2I9OKY2LcS76Y33-h9gZNeuRnNqGWg',
    libraries: ['places']
  })
];

@NgModule({
  imports: [MaterialComponents],
  exports: [MaterialComponents]
})
export class MaterialModule { }
