import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css'],
})


export class ServersComponent {

  serverid: number = 200;
  serverStatus: string = 'Offline';
  serverCreated: string = 'Not Yet';
  servername: string = ' ';
  addNewServer: boolean = false;
serverlist=['sql','oracle'];

  constructor() {
    setTimeout(() => {
      this.addNewServer = true;
    }, 5000);
  }

  // onserverNameEntry(event: Event) {
  //   console.log(event);
  //   this.servername=(<HTMLInputElement>event.target).value;
  // }

  onServerCreation() {
    this.serverCreated = 'created';
    this.serverlist.push(this.servername)
  }

 

  getServerId() {
    return this.serverid;
  }
  getServerStatus() {
    return this.serverStatus;
  }
}
