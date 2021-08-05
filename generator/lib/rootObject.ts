export interface Flag {
  name: string;
  kind: string;
  char: string;
  description: string;
  longDescription: string;
  required: boolean;
  type: string;
  values: string[];
}

export interface Result {
  command: string;
  id: string;
  description: string;
  help: string;
  flags: { [key: string]: Flag };
  flagsConfig: { [key: string]: Flag };
  supportsUsername: boolean;
  supportsDevhubUsername: boolean;
  usage: string;
  examples: string[];
}