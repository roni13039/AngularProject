import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { map } from 'rxjs';

@Component({
  selector: 'app-item-modal',
  templateUrl: './item-modal.component.html',
  providers: [NgbModal]
})
export class ItemModalComponent implements OnInit {

  constructor(  public modalService: NgbModal,private httpService: HttpClient) 
  {

  }
  
  myFiles:string [] = [];
  sMsg:string = '';

  ngOnInit(): void 
  {


  }
  getFileDetails(e:any)
  {
    //console.log (e.target.files);
    for (var i = 0; i < e.target.files.length; i++) { 
      this.myFiles.push(e.target.files[i]);
    }
  }
  
  uploadFiles () 
  {
    const frmData = new FormData();
    
    for (var i = 0; i < this.myFiles.length; i++) { 
      frmData.append("fileUpload", this.myFiles[i]);
    }
    debugger;
    this.httpService.post<any>('http://localhost:6001/api/Item/UploadFiles',{}).subscribe(
      {
      next: data =>
      {
          console.log(data);
      },
      error: error =>
      {
        
          console.error('There was an error!', error);
      }
    });
  }


  saveItem()
  {

    alert('okk');
  }

}
