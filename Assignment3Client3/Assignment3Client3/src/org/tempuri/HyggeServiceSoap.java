/**
 * HyggeServiceSoap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface HyggeServiceSoap extends java.rmi.Remote {
    public java.lang.String helloWorld() throws java.rmi.RemoteException;
    public org.tempuri.ViewAllResponseViewAllResult viewAll(java.lang.String table) throws java.rmi.RemoteException;
    public java.lang.Object[][] getTableAsList(java.lang.String tableName) throws java.rmi.RemoteException;
}
