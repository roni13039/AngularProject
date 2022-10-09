import { Component } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ItemModalComponent } from './item-modal/item-modal.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent 
{
  title = 'AngularApp';

  constructor( public modalSvc: NgbModal,)
  {

  }
  ngOnInit(): void 
  {
   this.getDefaultData();
  }

  getDefaultData() // drop down list
  {


  }
  OpenItemModal()
  {
   this.modalSvc.open(ItemModalComponent,{backdrop : 'static', keyboard : false});

  }
}
