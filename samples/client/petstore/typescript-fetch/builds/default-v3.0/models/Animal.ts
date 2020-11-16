/* tslint:disable */
/* eslint-disable */
/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import {
     DogFromJSONTyped,
     CatFromJSONTyped
} from './';

/**
 * 
 * @export
 * @interface Animal
 */
export interface Animal {
    /**
     * 
     * @type {string}
     * @memberof Animal
     */
    className: string;
    /**
     * 
     * @type {string}
     * @memberof Animal
     */
    color?: string;
}

export function AnimalFromJSON(json: any): Animal {
    return AnimalFromJSONTyped(json, false);
}

export function AnimalFromJSONTyped(json: any, ignoreDiscriminator: boolean): Animal {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    if (!ignoreDiscriminator) {
        if (json['className'] === 'Dog') {
            return DogFromJSONTyped(json, true);
        }
        if (json['className'] === 'Cat') {
            return CatFromJSONTyped(json, true);
        }
    }
    return {
        
        'className': json['className'],
        'color': !exists(json, 'color') ? undefined : json['color'],
    };
}

export function AnimalToJSON(value?: Animal | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'className': value.className,
        'color': value.color,
    };
}

