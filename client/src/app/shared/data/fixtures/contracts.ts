import { Contract } from '../../types/contract';

export const contractsFixture: Contract[] = [
	{   
		id: 1,
		name: 'Test Contract 1',
		signed: true,
		description: 'Just a test contract',
		thumbnailUrl: 'test',
		instanceUrl: 'test'
	},
	{
		id: 2,
		name: 'Test Contract 2',
		signed: false,
		description: 'Just another test contract',
		thumbnailUrl: 'test',
		instanceUrl: 'test'
	},
	{
		id: 3,
		name: 'Test Contract 3',
		signed: false,
		description: 'Just the third test contract',
		thumbnailUrl: 'test',
		instanceUrl: 'test'
	},
	{
		id: 4,
		name: 'Test Contract 3',
		signed: true,
		description: 'Just the third test contract',
		thumbnailUrl: 'test',
		instanceUrl: 'test'
	},
	{
		id: 5,
		name: 'Test Contract 3',
		signed: false,
		description: 'Just the third test contract',
		thumbnailUrl: 'test',
		instanceUrl: 'test'
	}
]