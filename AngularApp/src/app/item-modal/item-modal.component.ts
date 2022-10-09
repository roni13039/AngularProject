import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-item-modal',
  templateUrl: './item-modal.component.html',
  providers: [NgbModal]
})
export class ItemModalComponent implements OnInit {

  constructor(  public modalService: NgbModal) 
  {

  }

  ngOnInit(): void 
  {


  }
  saveItem(){
    alert('okk');
  }

}
