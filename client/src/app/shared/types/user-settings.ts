import { ModuleSettings } from './module-settings';

export interface UserSettings {
	moduleID: number,
	moduleName: string,
	settings: ModuleSettings[];
}