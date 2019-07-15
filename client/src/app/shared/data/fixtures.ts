import { userFixture } from './fixtures/user';
import { adminUserFixture } from './fixtures/adminUser';
import { contractsFixture } from './fixtures/contracts';
import { securityGroupsFixture } from './fixtures/securityGroups';
import { approvedSecurityGroupsFixture } from './fixtures/approvedSecurityGroups';
import { trainingsFixture } from './fixtures/trainings';
import { moduleProgressFixture } from './fixtures/moduleProgress';
import { userProgressFixture } from './fixtures/userProgress';
import { departmentProgressFixture } from './fixtures/departmentProgress';
import { userSettingsFixture } from './fixtures/userSettings';
import { usersFixture } from './fixtures/users';


export const Fixtures = {
	user: userFixture,
	users: usersFixture,
	adminUser: adminUserFixture,
    contracts: contractsFixture,
    securityGroups: securityGroupsFixture,
	approvedSecurityGroups: approvedSecurityGroupsFixture,
	trainings: trainingsFixture,
	moduleProgress: moduleProgressFixture,
	userProgress: userProgressFixture,
	departmentProgress: departmentProgressFixture,
	userSettings: userSettingsFixture
}