import { Component, OnInit } from '@angular/core';
import { ContractsService } from '../../contracts.service';
import { Contract } from 'src/app/shared/types/contract.class';

@Component({
  selector: 'app-contracts',
  templateUrl: './contracts.component.html',
  styleUrls: ['./contracts.component.scss']
})
export class ContractsComponent implements OnInit {
	private contracts: Contract[] = [];

  constructor(
	  private contractsService: ContractsService
  ) { }

  ngOnInit() {
	this.contractsService.contractChanged.subscribe( (newContracts: Contract[]) => {
		this.contracts = newContracts;
	});
  }
}
