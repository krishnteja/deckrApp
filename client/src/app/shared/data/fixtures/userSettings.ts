import { UserSettings } from '../../types/user-settings';

export const userSettingsFixture: UserSettings[] = [
	{
		moduleName: "Registration",
		moduleID: 1,
		settings: [
			{
				settingID: 1,
				settingName: "Filter Options",
				settingDescription: "Filter options when selected change the user progress view",
				settingValue: 0
			}
		]
	},	
	{
		moduleName: "Login",
		moduleID: 2,
		settings: [
			{
				settingID: 1,
				settingName: "Filter Options",
				settingDescription: "Filter options when selected change the user progress view",
				settingValue: 0
			}
		]
	},	
	{
		moduleName: "User Home",
		moduleID: 1,
		settings: [
			{
				settingID: 1,
				settingName: "Filter Options",
				settingDescription: "Filter options when selected change the user progress view",
				settingValue: 0
			}
		]
	},	
	{
		moduleName: "Trainings",
		moduleID: 1,
		settings: [
			{
				settingID: 1,
				settingName: "Filter Options",
				settingDescription: "Filter options when selected change the user progress view",
				settingValue: 0
			}
		]
	},	
	{
		moduleName: "Contracts",
		moduleID: 1,
		settings: [
			{
				settingID: 1,
				settingName: "Filter Options",
				settingDescription: "Filter options when selected change the user progress view",
				settingValue: 0
			},
			{
				settingID: 2,
				settingName: "Navigation Options",
				settingDescription: "Navigation options that allow the user to navigate to other modules",
				settingValue: 1
			},
			{
				settingID: 1,
				settingName: "Terms of Employment",
				settingDescription: "Contract for Terms of Employment",
				settingValue: 1
			},
			{		
				settingID: 2,
				settingName: "Non-Disclosure Agreement",
				settingDescription: "Contract for Non-Disclosure Agreement",
				settingValue: 0
			}
		]
	},	
	{
		moduleName: "Security Groups",
		moduleID: 1,
		settings: [
			{
				settingID: 1,
				settingName: "Filter Options",
				settingDescription: "Filter options when selected change the user progress view",
				settingValue: 0
			}
		]
	}
]
