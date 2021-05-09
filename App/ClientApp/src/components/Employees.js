import React, { Component } from 'react';
import ErrorModal from './ErrorModal';
export class Employees extends Component {
    displayName = Employees.name

    constructor(props) {
        super(props);
        this.state = {
            employeeId: '', employees: [], showModal: false
        }
    };


    handlerOnClick = () => {

        let apiURL = 'api/employees';
        const oneEmployee = this.state.employeeId !== "";
        if (oneEmployee) {
            apiURL += `/${this.state.employeeId}`;
        }
        fetch(apiURL)
            .then(response => response.json())
            .then(data => {
                this.setState({ loading: false });
                this.setState({ employees: oneEmployee ? [data] : data });
            }

            ).catch(() => {
                this.setState({ showModal: true });
            });
    }

    handlerOnChange = (event) => {
        this.setState({ employeeId: event.target.value });
    }
    renderEmployeesTable() {
        return (
            <table className='table table-striped'>
                <thead>
                    <tr>
                        <th scope="col">Id</th>
                        <th scope="col">Name</th>
                        <th scope="col">Contract Name</th>
                        <th scope="col">Annual Salary</th>
                        <th scope="col">Rol Name</th>
                        <th scope="col">Rol Description</th>
                    </tr>
                </thead>
                <tbody>
                    {this.state.employees.map(employee =>
                        <tr scope="row" key={employee.id}>
                            <td>{employee.id}</td>
                            <td>{employee.name}</td>
                            <td>{employee.contractType.name}</td>
                            <td >{employee.contractType.annualSalary}</td>
                            <td>{employee.rol.roleName}</td>
                            <td>{employee.rol.roleDescription === null ? '-' : employee.rol.roleDescription}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {

        return (

            <div style={{ marginLeft: 10 }}>
                <h1>Employees App</h1>
                <p>Please enter an employee id</p>
                <input type="number" min="1" onChange={this.handlerOnChange} value={this.state.employeeId} />
                <button style={{ marginLeft: 5 }} onClick={this.handlerOnClick}>Search</button>
                {this.state.employees.length > 0 && this.renderEmployeesTable()}

                <ErrorModal show={this.state.showModal} onHide={() => this.setState({ showModal: false })} />
            </div>

        );
    }
}
